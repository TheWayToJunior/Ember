using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ember.Shared
{
    public class BindAccountInfo
    {
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(6)]
        public string Number { get; set; }
    }
}
