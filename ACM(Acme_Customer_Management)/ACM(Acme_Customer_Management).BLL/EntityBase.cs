﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public enum EntityStateOpcion
    {
        Active,
        Deleted
    }   
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        public EntityStateOpcion EntityState { get; set; }


        public abstract bool Validate();
       
    }
}
