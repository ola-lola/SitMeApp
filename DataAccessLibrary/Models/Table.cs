﻿using System;
using DataAccessLibrary.Base;

namespace DataAccessLibrary.Models
{
    public class Table : Domain
    {
        public static string TableName { get; } = "[Manager].[Table]";
        
        public string Name { get; set; }

        public Guid TableTypeId { get; set; }
        
        public byte MaxNbOfSeats { get; set; }
        
        public byte[] Picture { get; set; }
        
        public string LocationInRestaurant { get; set; }
        
        public bool IsVisibleForUsers { get; set; }
        
        public Guid RestaurantId { get; set; }
    }
}