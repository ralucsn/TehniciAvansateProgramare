﻿namespace WebAPI.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid TypeId { get; set; }
    }
}
