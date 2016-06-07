using System;
using System.Diagnostics;
using System.Linq;

namespace DapperSample
{
    class LinqToSQL
    {
        public TimeSpan RunTestOne()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (byte i = 0; i < 20; i++)
                RunCommands();

            watch.Stop();
            return watch.Elapsed;
        }

        public void RunCommands()
        {
            // Initialize Linq Context
            using (LinqDataContext context = new LinqDataContext())
            {
                // Initialize Model
                ShowroomModel model = new ShowroomModel("Linq to SQL Test");

                // Create entity object
                var entity = new Showroom();
                entity.IsActive = model.IsActive;
                entity.ShowroomId = model.ShowroomId;
                entity.ShowroomName = model.ShowroomName;

                // Insert record
                context.Showrooms.InsertOnSubmit(entity);
                context.SubmitChanges();

                // Select Record
                entity = context.Showrooms.Where(s => s.ShowroomId == model.ShowroomId).FirstOrDefault();
                model.ShowroomId = entity.ShowroomId;
                model.ShowroomName = entity.ShowroomName;
                model.IsActive = entity.IsActive;

                // Update Record
                model.IsActive = true;
                entity.IsActive = model.IsActive;
                context.SubmitChanges();
            }
        }
    }
}