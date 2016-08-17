namespace yogaRx.Migrations
{
    using yogaRx.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

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
                        PoseName = "Extended Puppy Pose",
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
            var cor = context.Poses.Single(item => item.PoseName == "Corpse Pose");
            cor.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Depression"));                    
            cor.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));
            cor.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Insomnia"));

            var legs = context.Poses.Single(item => item.PoseName == "Legs Up The Wall");
            legs.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));
            legs.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Depression"));
            legs.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Insomnia"));

            var epp = context.Poses.Single(item => item.PoseName == "Extended Puppy Pose");
            epp.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));
            epp.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Anxiety"));

            var seatff = context.Poses.Single(item => item.PoseName == "Seated Forward Fold");
            seatff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));
            seatff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Backache"));
            seatff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "PMS"));
            seatff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Sciatica"));
            seatff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Insomnia"));

            var stanff = context.Poses.Single(item => item.PoseName == "Standing Forward Fold");
            stanff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Depression"));
            stanff.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));

            var dDog = context.Poses.Single(item => item.PoseName == "Downward Facing Dog");
            dDog.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Sciatica"));
            dDog.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Headache"));

            var catcow = context.Poses.Single(item => item.PoseName == "Cat/Cow Pose");
            catcow.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Anxiety"));
            catcow.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Energizing"));
            catcow.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Backache"));

            var child = context.Poses.Single(item => item.PoseName == "Child's Pose");
            child.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));
            child.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "PMS"));
            child.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Backache"));

            var suptwi = context.Poses.Single(item => item.PoseName == "Supine Twist");
            suptwi.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));

            var loc = context.Poses.Single(item => item.PoseName == "Locust Pose");
            loc.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Backache"));
            loc.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Energizing"));
            loc.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Sciatica"));

            var pigeon = context.Poses.Single(item => item.PoseName == "Pigeon Pose");
            pigeon.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "PMS"));

            var bond = context.Poses.Single(item => item.PoseName == "Bond Angle Pose");
            bond.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "PMS"));
            bond.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Anxiety"));

            var creslun = context.Poses.Single(item => item.PoseName == "Crescent Lunge");
            creslun.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Depression"));

            var wilthing = context.Poses.Single(item => item.PoseName == "Wild Thing");
            wilthing.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Depression"));

            var fish = context.Poses.Single(item => item.PoseName == "Fish Pose");
            fish.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "PMS"));
            fish.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Anxiety"));

            var plow = context.Poses.Single(item => item.PoseName == "Plow Pose");
            plow.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Insomnia"));

            var tri = context.Poses.Single(item => item.PoseName == "Triangle Pose");
            tri.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));
            tri.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Energizing"));

            var revplan = context.Poses.Single(item => item.PoseName == "Reverse Plank");
            revplan.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Sciatica"));
            revplan.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Energizing"));

            var chair = context.Poses.Single(item => item.PoseName == "Chair Pose");
            chair.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Energizing"));

            var tabtop = context.Poses.Single(item => item.PoseName == "Table Top with Reversed Hands");
            tabtop.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Carpal Tunnel Syndrome"));

            var eagle = context.Poses.Single(item => item.PoseName == "Eagle Arms");
            eagle.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Carpal Tunnel Syndrome"));

            var cowface = context.Poses.Single(item => item.PoseName == "Cow Face Arms");
            cowface.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Carpal Tunnel Syndrome"));

            var wrist = context.Poses.Single(item => item.PoseName == "Wrist Workout");
            wrist.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Carpal Tunnel Syndrome"));

            var dolp = context.Poses.Single(item => item.PoseName == "Dolphin Pose");
            dolp.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Carpal Tunnel Syndrome"));

            var war3 = context.Poses.Single(item => item.PoseName == "Warrior 3");
            war3.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));

            var highmount = context.Poses.Single(item => item.PoseName == "High Mountaing (Side Bend)");
            highmount.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));
















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
