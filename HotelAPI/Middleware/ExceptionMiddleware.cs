using FluentValidation;
using Humanizer;

namespace HotelAPI.Middleware
{
    using System.Net;
    using System.Text.Json;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;
    using System;
    using HotelAPI.Application.Exceptions;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;

    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (DuplicateEntryException ex)
            {
                _logger.LogError(ex, "DuplicateEntryException caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError(dbEx, "Database exception caught");
                await HandleExceptionAsync(context, dbEx);
            }
            catch (RoomBusyException ex)
            {
                _logger.LogError(ex, "RoomBusyException exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (NoMatchFoundException ex)
            {
                _logger.LogError(ex, "NoMatchFoundException exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (ValidationException ex)
            {
                _logger.LogError(ex, "Validation exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (ActiveReservationException ex)
            {
                _logger.LogError(ex, "ActiveReservationException exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError("InvalidOperationException exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError("ArgumentNullException exception caught");
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception caught");
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            var response = new { message = "An error occurred while processing your request." };
            var statusCode = (int)HttpStatusCode.InternalServerError;
            switch (ex)
            {
                case ArgumentNullException argNullEx:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    response = new { message = "Value was not found" };
                    break;

                case DuplicateEntryException:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new { message = "A record with this unique value already exists." };
                    break;

                case DbUpdateException dbEx when dbEx.InnerException is SqlException sqlEx && sqlEx.Number == 2601:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new { message = dbEx.InnerException.Message };
                    break;
                case DbUpdateException dbExc:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new { message = dbExc.InnerException.Message };
                    break;
                case RoomBusyException roomBusyEx:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new{message = roomBusyEx.Message};
                    break;
                case NoMatchFoundException noMatchEx:
                    statusCode = (int)HttpStatusCode.NotFound;
                    response = new { message = noMatchEx.Message };
                    break;
                case ValidationException validationEx:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    response = new { message = validationEx.Message };
                    break;
                case ActiveReservationException activeResEx:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new { message = activeResEx.Message };
                    break;
                case InvalidOperationException invalidOpEx:
                    statusCode = (int)HttpStatusCode.Conflict;
                    response = new { message = invalidOpEx.Message };
                    break;
                
                default:
                    _logger.LogError(ex, "Unhandled exception occurred.");
                    break;
            }

            context.Response.StatusCode = statusCode;
            return context.Response.WriteAsJsonAsync(response);
        }
    }

}
