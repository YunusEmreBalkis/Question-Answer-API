
using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Answer:IEntity
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int LikeCount { get; set; }
    }
}
