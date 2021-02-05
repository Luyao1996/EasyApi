using Easy.models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Easy.models
{

    public class MTest : AutoValid
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime DT { get; set; }
    }
}
