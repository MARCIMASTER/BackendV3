using System;

namespace Backend.DTO.AccountDTO
{
    public class AuthenticationResponse
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }


    }
}
