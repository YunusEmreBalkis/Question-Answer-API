using Core;
using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class QuestionDetailDTO:IDto
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
