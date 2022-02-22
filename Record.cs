﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DochazkovySystem
{
    public class Record
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public RecordReason Reason{get; set;}
        public Guid Guid { get; set; }
        public Person Person { get; set; }

        public Record()
        {
            Guid = Guid.NewGuid();
            
        }
    } 
    public enum RecordReason
    {
        StartShift,
        EndShift,
        StartPause,
        EndPause,
        StartDoctor,
        EndDoctor,
    }
}
