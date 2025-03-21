﻿namespace HotelAPI
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }

        public ApiResponse(bool success, string message, T data, int statusCode)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = statusCode;
        }

        public static ApiResponse<T> CreateSuccessResponse(T data, string message = "Request was successful")
        {
            return new ApiResponse<T>(true, message, data, 200);
        }

        public static ApiResponse<T> CreateErrorResponse(string message, int statusCode)
        {
            return new ApiResponse<T>(false, message, default(T), statusCode);
        }
    }
}