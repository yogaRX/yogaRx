namespace yogaRx.Migrations
{
    using yogaRx.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<yogaRx.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(yogaRx.Models.ApplicationDbContext context)
        {

            context.Ailments.AddOrUpdate(p => p.AilmentName,
               new Ailment
               {
                   AilmentName = "Depression",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Anxiety",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Insomnia",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Digestion",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Carpal Tunnel",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Sciatica",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Energizing",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Headache",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "Backache",
                   AilmentDesc = "",

               },
               new Ailment
               {
                   AilmentName = "PMS",
                   AilmentDesc = "",

               }



                );

                 context.Poses.AddOrUpdate(p => p.PoseName,
                    new Pose
                    {
                        PoseName = "Legs Up the Wall",
                        PoseDesc = ""

                    },
                    new Pose
                    {
                        PoseName = "Extended Puppy Dog Pose",
                        PoseDesc = ""
                    },
                    new Pose
                    {
                        PoseName = "Seated Forward Fold",
                        PoseDesc= ""
                    },
                      new Pose
                      {
                          PoseName = "Standing Forward Fold",
                          PoseDesc = ""
                      },
                       new Pose
                       {
                          PoseName = "Downward Facing Dog",
                          PoseDesc = ""
                       },
                       new Pose
                        {
                              PoseName = "Corpse Pose",
                              PoseDesc = ""
                        },
                       new Pose
                       {
                           PoseName = "Cat/ Cow Pose",
                           PoseDesc = ""
                       },
                      new Pose
                      {
                              PoseName = "Child's Pose",
                              PoseDesc = ""
                      },
                       new Pose
                       {
                           PoseName = "Supine Twist",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Locust Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Pigeon Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Bound Angle Pose",
                           PoseDesc = ""
                       },  
                       new Pose
                       {
                           PoseName = "Crescent Lunge",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Wild Thing",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Fish Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Plow Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Triangle Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Reverse Plank",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Chair Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Table Top (Reverse Hands)",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Eagle Arms",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Cow Face Arms",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Wrist Workout",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Dolphin Pose",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "Warrior 3",
                           PoseDesc = ""
                       },
                       new Pose
                       {
                           PoseName = "High Mountain (Side bend)",
                           PoseDesc = ""
                       }


                    );
        }
        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data. E.g.
        //
        //    context.People.AddOrUpdate(
        //      p => p.FullName,
        //      new Person { FullName = "Andrew Peters" },
        //      new Person { FullName = "Brice Lambson" },
        //      new Person { FullName = "Rowan Miller" }
        //    );
        //
    }
    
}
