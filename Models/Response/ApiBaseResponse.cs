﻿namespace Models.Response
{
    public abstract class ApiBaseResponse
    {
        public bool Success { get; set; }
        protected ApiBaseResponse(bool success) => Success = success;
    }
}
