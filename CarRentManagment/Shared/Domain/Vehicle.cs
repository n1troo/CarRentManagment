﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentManagment.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public int ModelId { get; set; }    
        public virtual Model? Model { get;set; }

        public int KolorId { get; set; }
        public virtual Kolor? Kolor { get; set; }

        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }

        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking>? Bookings { get; set; }

    }
}
