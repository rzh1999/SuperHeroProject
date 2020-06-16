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

        [Display(Name ="Name")]
        public string name { get; set; }
        [Display(Name = "Alter Ego")]
        public string alterEgo { get; set; }

        [Display (Name = "Primary Ability")]
        public string primaryAbility { get; set; }

        [Display (Name = "Secondary Ability")]
        public string secondaryAbility { get; set; }

        [Display (Name = "Catch Phrase")]
        public string catchPhrase { get; set; }

    }
}
