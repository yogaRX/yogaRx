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
                   AilmentName = "Carpal Tunnel Syndrome",
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
                           PoseName = "Cat Cow Pose",
                           PoseDesc = "Begin on all fours, shoulders above your wrists and hips above your knees. Inhale drop your belly and look up to the sky coming into cow pose. Exhale bring your navel to your spine, pushing through the floor, rounding your spine and looking back to your thighs. Repeat this for as many cycles of breath that your body needs."+"\r\n"+ "Modification: Place a blanket under knees if sensitive."
                       },
                      new Pose
                      {
                              PoseName = "Child's Pose",
                              PoseDesc = "Balasana"+"\r\n"+ "Begin on all fours, spread your knees wider than hip distance or keep them together, take a deep inhale on the exhale sink your hips toward your heels and slowly walk your hands out in front of you bringing your forehead to the ground and let your chest melt toward the floor. Hold for as long as you need."+"\r\n"+ "Modification: Roll up a blanket and place it horizontally over your calves to release pressure in your knees, place a pillow or bolster in between legs bringing your chest to rest on it."
                      },
                       new Pose
                       {
                           PoseName = "Supine Twist",
                           PoseDesc = "Supta Matsyendrasana"+"\n"+ "Lie on your back, bending your knees and bringing into your chest, wrapping your arms around your shins and rocking from side to side, massaging your lower back. Inhale back to center spreading your arms out to a T palms facing the ground. Exhale slowly drop your knees to the right, keeping both of your shoulders firmly planted into the ground. Use your inhales to lengthen your spine and your exhales to twist a little bit deeper. Stay here as long as your body needs, repeat on the left side."+"\n"+ "Modification: Roll up a blanket and placing underneath your knees if they don’t touch the ground."
                       },
                       new Pose
                       {
                           PoseName = "Locust Pose",
                           PoseDesc = "Salabhasana"+"\n"+ "Lie on your stomach, arms by your sides palms facing the floor, tops of your feet press into the ground, forehead comes to the floor inhale on the exhale lift your chest, arms and legs off of the ground and gaze in front of you. Take 3 cycles of breath here, releasing on the exhale. Repeat as many times as your body needs."+"\n"+ "Modification: Place folded blanket under hips."
                       },
                       new Pose
                       {
                           PoseName = "Pigeon Pose",
                           PoseDesc = "Eka Pada Rajakapotasana"+"\n"+ "In downward dog, raise your right leg to the sky, bring your knee to your nose then slowly lower your knee to the outside of your right wrist. Right shin can be parallel 	to the front of the room or close your your inner thigh. Your back quad should be face down on the ground, hips square to the front of the room. You take two variations, hands planted on the ground, while your collarbone broadens or inhale lengthen your spine and on the exhale slowly fold forward walking your hands out in front of you. Hold for 20 cycles of breath."+"\n"+ "Modification: Pigeon on back, lie on your back, bend your knees bringing your heels to touch your fingertips. Cross your right ankle over your left thigh. Inhale interlacing your hands in behind your left thigh, exhale hug your left knee into your chest and push your right knee to the front of the room. Hold for as long as you need. Repeat on other side."
                       },
                       new Pose
                       {
                           PoseName = "Bound Angle Pose",
                           PoseDesc = "Baddha Konasana"+"\n"+ "Begin seated with your knees bent and feet flat on the ground, bring your heels toward your pelvis, slowly begin to let your knees drop to the floor pushing the soles against each other. Grab ahold of your big toes with your two piece fingers, inhale lengthen your spine, exhale bend at the elbows pulling your chest toward your feet, keep your spine long by stopping before it starts to round. Hold for 20 cycles of breath."+"\n"+ "Modification: Sit on a folded blanket to help create space in the hips."
                       },  
                       new Pose
                       {
                           PoseName = "Crescent Lunge",
                           PoseDesc = "Anjaneyasana"+"\n"+ "Begin standing, rooting into the right foot, inhale and step your left foot to the back of the room staying on the ball of your left foot. Slowly bend into the right knee keeping it over your ankle. Inhale your arms up to the sky, exhale triceps wrap in as your palms come to face each other. Hold for 5 cycles of breath. Repeat on opposite side. "+"\n"+ "Modification: Bend in back knee or place the back knee on the floor. If knee is sensitive, place on a folded blanket."
                       },
                       new Pose
                       {
                           PoseName = "Wild Thing",
                           PoseDesc = "Camatkarasana"+"\n"+ "Begin in downward dog, bring weight into your right side rolling to the outer edge of your right foot coming into a side plank, inhale here on on the exhale step your left foot behind you bringing your toes to meet the ground and your knee to to a slight bend.Inhale your left tricep to frame your left ear as your collarbone broadens. Hold for 5 to 10 cycles of breath."
                       },
                       new Pose
                       {
                           PoseName = "Fish Pose",
                           PoseDesc = "Matsyasana"+"\n"+ "Lie on your back with your knees bent and feet on the floor. Inhale your pelvis toward your navel lifting it off the ground, as you exhale slide your hands palms down underneath your sit bones, then bring release your sit bones to rest on the tops of your hands. You can straighten your legs here or keep your knees bent. Inhale your chin to your chest lifting your head and upper body away from the ground rolling your forearms and elbows underneath your sides, exhale as you press them firmly against the ground as you lower the crown of your head towards the earth. Hold for 10 cycles of breath."+"\n"+ "Modification: Roll up a blanket and place it the length of your spine, place the crown of your head on a blanket or pillow."
                       },
                       new Pose
                       {
                           PoseName = "Plow Pose",
                           PoseDesc = "Halasana"+"\n"+ "Lie on your back with your arms by your side palms facing the ground. Inhale bringing your knees into your chest, on the exhale press through your upper body, forearms and palms bringing your legs over your head and your toes to touch the ground. Wrap your shoulder blades into your back body straightening your legs. Hold for ten to 20 cycles of breath. When coming out of the pose bend your knees and slowly roll down one vertebrae at a time."+"\n"+ "Modification: Lay one or two folded blankets(place from the base of your neck to your lower back.If your toes don’t touch the ground place a pillow for them to connect with."
                       },
                       new Pose
                       {
                           PoseName = "Triangle Pose",
                           PoseDesc = "Utthita Trikonasana"+"\n"+ "Begin standing, heel toe your feet 3-4 feet apart turning you right toes 90 degrees, making sure your right heel intersects with your left arch. Bring your arms out to a T on the inhale lengthen your spine, exhale sliding your right arm out in front of you bringing it to your shin, floor or hooking your two peace fingers around your big toe. Use every inhale to lengthen your spine, every exhale to broaden your collarbone and twist a little deeper. Hold for 10 cycles of breath. Repeat on opposite side."
                       },
                       new Pose
                       {
                           PoseName = "Reverse Plank",
                           PoseDesc = "Purvottanasana"+"\n"+ "Start seated with your legs straight out in front of you, place your hands behind your sit bones fingertips pointing toward your feet. Inhale and on the exhale press your hands and heels into the ground lifting your hips off the ground, roll your shoulder blades into your back body broadening your collarbone. Hold for 5 cycles of breath, repeat one to two times."+"\n"+ "Modification: Start with bent knees and your feet firmly planted on the ground. Lift your hips keeping bent knees, if you feel comfortable here you can begin to straighten one leg at a time."
                       },
                       new Pose
                       {
                           PoseName = "Chair Pose",
                           PoseDesc = "Utkatasana"+"\n"+ "Begin standing, bring the two big toes to touch with tiny space between the heels or heel toe your feet hip distance. Inhale bringing your arms up to the sky bringing your palms to face each other, exhale sink your hips toward the ground making sure you can still see your toes in front of your knees. Bring the weight into your heels. Hold for 5 cycles of breath."
                       },
                       new Pose
                       {
                           PoseName = "Table Top with Reversed Hands",
                           PoseDesc = "Begin on all fours, shoulders above your wrists, hips above your knees. Triceps wrap in turning your fingertips to face your knees. Inhale and on the exhale sink your sit bones to your heels until you feel a stretch in your wrists. Hold for a couple cycles of breath, increasing the time with every cycle"+"\n"+ "Modification: Fold a blanket and place it under your knees."
                       },
                       new Pose
                       {
                           PoseName = "Eagle Arms",
                           PoseDesc = "Garudasana Arms"+"\n"+ "Begin in a comfortable seated position, bring your arms out to a T, inhale and as you exhale cross your right arm underneath your left bringing your triceps to touch. Bend at the elbows and bring the backs of your hands and forearms to touch or if you are feeling open cross your right forearm over your left bringing your palms to touch, Inhale bringing your elbows to the height of your shoulders. Hold for 10 cycles of breath. Repeat on opposite side."
                       },
                       new Pose
                       {
                           PoseName = "Cow Face Arms",
                           PoseDesc = "Gomukasana Arms"+"\n"+ "Begin in a comfortable seated position, inhale bringing your right arm up to the sky palm facing to the left, exhale bend at the elbow bringing the palm of your hand in between your shoulderblades as your tricep wraps in, inhale here on the exhale bend your left elbow bringing the back of your hand in between your shoulder blades and grab ahold of your right hand. Hold for 10 cycles of breath. Repeat on opposite side."+"\n"+ "Modification: Hold a strap, shirt or towel in your right hand, if your left hand doesn’t meet the right grab ahold of the object and walk your hand up as you feel comfortable."
                       },
                       new Pose
                       {
                           PoseName = "Wrist Workout",
                           PoseDesc = "Begin in a comfortable seat, inhale bringing your arms straight out in front of you, exhale bend at the elbows and begin shaking your hands, continue this for 30 second to 1 minute."+"\n"+ "In the same position make fists with your hands begin rolling your wrists in one direction the switching and rolling them in the other direction, continue this for as long as your body needs."
                       },
                       new Pose
                       {
                           PoseName = "Dolphin Pose",
                           PoseDesc = "Begin on all fours, walk your hands forearm distance away from your shoulders. Bring your forearms to the ground, palms facing down. Inhale curl your toes under, lift your hips toward the sky straightening your legs. Bring your shoulders onto your back body by pushing your head away from your hands. Hold for 10 cycles of breath."+"\n"+ "Modification: Slight bend in the knees."
                       },
                       new Pose
                       {
                           PoseName = "Warrior 3",
                           PoseDesc = "Virabhadrasana 3"+"\n"+ "Begin in a standing position, arms active by your sides. Bring weight into your right foot and slowly begin to lean forward as you straighten your left leg behind you. Keeping your hips square to the ground press your left foot to the back of the room. You can keep your arms by your side or bring them out in front of you to frame your ears. Hold for 5 cycles of breath. Repeat on opposite side."+"\n"+ "Modification: Slight bend in the standing leg."
                       },
                       new Pose
                       {
                           PoseName = "Crescent Moon",
                           PoseDesc = "Begin standing with your arms by your side. Inhale bringing your arms up to the sky, interlace your fingers exhale and side bend to the right keeping your weight even in both hips. Inhale come back to center, exhale and side bend to the left keeping weight even in both hips. Hold for 5 cycles of breath on each side. Repeat twice."
                       }


                    );
            context.SaveChanges();
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

            var catcow = context.Poses.Single(item => item.PoseName == "Cat Cow Pose");
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

            var bond = context.Poses.Single(item => item.PoseName == "Bound Angle Pose");
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
