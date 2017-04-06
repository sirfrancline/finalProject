using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Writers
{
    public class RentalWriter


    {

        private RentalReader _reader  = new RentalReader();

        string _fileName = @"TextFiles\rental.txt";

        public void Add(Issue issue) {
            var list = _reader.GetAllRentals();
        }
    }
}