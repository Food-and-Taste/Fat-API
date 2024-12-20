﻿namespace FatApi.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<Recipes> Recipes { get; set; } = new();
        public List<Reviews> Reviews { get; set; } = new();
        public List<Lists> List { get; set; } = new();
    }
}
