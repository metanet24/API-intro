﻿namespace Api_Intro.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate{ get; set; }
    }
}
