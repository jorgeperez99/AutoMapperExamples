﻿using System;
using System.Collections.Generic;

namespace AutoMapperExamples.Entity
{
    public abstract class ContactBase : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}