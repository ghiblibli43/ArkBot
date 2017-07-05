﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkBot.WebApi.Model
{
    public class StructuresViewModel
    {
        public StructuresViewModel()
        {
            Structures2 = new List<float[]>();
            Structures = new List<StructureViewModel>();
            Types = new List<StructureTypeViewModel>();
            Owners = new List<StructureOwnerViewModel>();
        }
        public string MapName { get; set; }
        public List<float[]> Structures2 { get; set; }
        public List<StructureViewModel> Structures { get; set; }
        public List<StructureTypeViewModel> Types { get; set; }
        public List<StructureOwnerViewModel> Owners { get; set; }
    }
}
