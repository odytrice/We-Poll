﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WePoll.Domain.Models
{
    public class UserModel : Model
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }


        public virtual ICollection<RespondentModel> Respondents { get; set; } = new HashSet<RespondentModel>();
    }
}