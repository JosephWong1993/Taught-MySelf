using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter06to08.BusinessLogic
{
    public partial class Subject
    {
        public Guid ObjectId = Guid.NewGuid();

        public static void UpdateSubject(Subject changingSubject)
        {
            LinqBooksDataContext context = new LinqBooksDataContext();

            Subject existingSubject = context.Subject.Where(subject => subject.ID == changingSubject.ID).FirstOrDefault();
            existingSubject.Name = changingSubject.Name;
            existingSubject.Description = changingSubject.Description;
            context.SubmitChanges();
        }
    }
}
