using Application.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OldMcDonald.web.Models
{
    public class AddEditVM
    {
        public Animal Animal                { get; set; }
        public Farm Farm                    { get; set; }
        public string Title                 { get; set; }
        public string ButtonMessage         { get; set; }
    }
}