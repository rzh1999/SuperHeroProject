using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class SuperHeroModel
    {
        [Key]
        public int Id { get; set; }
        private string name { get; set; }
        private string alterEgo { get; set; }
        private string primaryAbility { get; set; }
        private string secondaryAbility { get; set; }
        private string catchPhrase { get; set; }

    }
}
