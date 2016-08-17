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
                        PoseDesc = "Viparita Karani" + "\r\n" + "Sit on the floor bringing your dominate (right or left) side to the wall, place your hand on the floor facing your fingertips to touch the wall and the heel of your hand to touch your outer hip. On an inhale place your hands behind you, as you exhale swing your legs up onto the wall, scooting your sit bones closer to the wall if you’re feeling far away. Take a deep inhale and on the exhale let your shoulder blades move into your back body while your arms and palms open up to the ceiling by your sides, relaxing your jaw and bringing your eyes to shut. Hold for 5 to 10 minutes." + "\r\n" + "Modification: Bring a bolster or pillow under lower back, keeping distance in between you and the wall if you’re feeling tight."



                    },
                    new Pose
                    {
                        PoseName = "Extended Puppy Pose",
                        PoseDesc = "Uttana Shishosana" + "\r\n" + "Begin on all fours, making sure  your shoulders are above your wrists and  your hips are above your knees. Inhale and as you exhale walk your hands slowly out in front of you, keeping your hips above your knees. Keeping active arms, slowly bring your forehead to a block, blanket, or the ground. Using every inhale to lengthen your spine and every exhale to bring your hips back over your knees. Hold for 10 cycles of breath."+"\r\n"+ "Modification: Place a blanket under your knees, rest forehead/upper body on a bolster or pillow."


                    },
                    new Pose
                    {
                        PoseName = "Seated Forward Fold",
                        PoseDesc= "Paschimottanasana"+"\r\n"+ "Sit on the floor with your legs straight (slight bend in the knee for tight hamstrings) out in front of you, inhale your arms up to the sky lengthening your spine, and rolling your shoulder blades into your back body, exhale slowly hinging at the hips folding forward till your hands reach your shins or feet. Breathe here using every inhale to lengthen the spine and exhale to fold a little deeper. Hold for 10 to 20 cycles of breath"+"\r\n"+ "Modification: Sit on a folded blanket to help give a little more space in the hips."
                    },
                      new Pose
                      {
                          PoseName = "Standing Forward Fold",
                          PoseDesc = "Uttanasana"+"\r\n"+ "Standing in mountain pose, bringing feet together or hip distance. Inhale your arms up to the sky bringing shoulder blades onto the back body, lengthening the spine. Exhale and slowly begin to hinge at the hips bringing your hands to your shins, the floor or grab ahold of opposite elbows. Hold for 10 to 20 cycles of breath." +"\r\n"+ "Modification: Slight bend in the knees for tight hamstrings, also will protect your lower back."

                      },
                       new Pose
                       {
                          PoseName = "Downward Facing Dog",
                          PoseDesc = "Adho Mukha Svanasana "+"\r\n"+ "Begin in child's pose, letting your hips sink to your heels while keeping active arms. Inhale curl your toes under and on the exhale lift your hips to the sky, pushing your chest toward your thighs. Triceps wrap in as your shoulder blades move onto your back body, tailbone lengthens toward your heels and heels press toward or into the earth. hold for 10 cycles of breath. "+"\r\n"+ "Modification: Place your forehead on a block, roll up a blanket to place under your heels if they don’t reach the ground, and taking a slight bend in the knees if your hamstrings are tight."
                       },
                       new Pose
                        {
                              PoseName = "Corpse Pose",
                              PoseDesc = "Savasana"+"\r\n"+ "Lie on your back , spread your feet wider than your hips, letting them drop open to the sides. Bring your arms down by your sides, spreading them wider than your shoulders, opening your palms to the sky and bringing your eyes to close. Hold for as long as you need."+"\r\n"+ "Modification: Place rolled blanket under knees, place one hand on your chest and one on your belly."
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
                           PoseName = "Crescent Moon",
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

            var cresmoon = context.Poses.Single(item => item.PoseName == "Crescent Moon");
            cresmoon.Ailments.Add(context.Ailments.Single(item => item.AilmentName == "Digestion"));
















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
