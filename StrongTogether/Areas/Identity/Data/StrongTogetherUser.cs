﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StrongTogether.Areas.Identity.Data;

// Add profile data for application users by adding properties to the StrongTogetherUser class
public class StrongTogetherUser : IdentityUser
{
    public int StrongTogetherUserId { get;set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Gender { get; set; }
    public int FootHeight { get; set; }
    public int InchHeight { get; set; }
    public int Weight { get; set; }
/*    [ForeignKey("Fitness Goal")]
    public int? FitnessId { get; set; }
    public FitnessGoal FitnessGoal { get; set; } */
}

