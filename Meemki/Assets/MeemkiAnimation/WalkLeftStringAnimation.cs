﻿using System.Collections.Generic;
using Meemki.Model;

namespace Meemki.Assets.MeemkiAnimation
{
    public class WalkLeftStringAnimation : IStringAnimation
    {
        private string WalkingPose1 =
        @"O" + '\x0' +
        @" >" + '\x0' +
        @" /\_" + '\x0' +
        @" \  ´" + '\x0' +
        @" Í" + '\x0';

        private string WalkingPose2 =
        @"O" + '\x0' +
        @" >" + '\x0' +
        @" /_" + '\x0' +
        @"  \´" + '\x0' +
        @"  Í" + '\x0';

        private string WalkingPose3 =
        @"O" + '\x0' +
        @" \>" + '\x0' +
        @"<_\" + '\x0' +
        @"  ´\" + '\x0' +
        @"   Í" + '\x0';

        private string WalkingPose4 =
        @"O" + '\x0' +
        @" \>" + '\x0' +
        @" /\" + '\x0' +
        @"|  `." + '\x0' +
        @"Í   Í" + '\x0';

        private string WalkingPose5 =
        @"O" + '\x0' +
        @" >" + '\x0' +
        @" /\_" + '\x0' +
        @" \  ´" + '\x0' +
        @" Í" + '\x0';

        private string WalkingPose6 =
        @"O" + '\x0' +
        @" >" + '\x0' +
        @" /|" + '\x0' +
        @"  \´" + '\x0' +
        @"  Í" + '\x0';

        private string WalkingPose7 =
        @"O" + '\x0' +
        @" \" + '\x0' +
        @"<_\" + '\x0' +
        @"  ´\" + '\x0' +
        @"   Í" + '\x0';

        private string WalkingPose8 =
        @"O" + '\x0' +
        @" \" + '\x0' +
        @" /\" + '\x0' +
        @"|  `." + '\x0' +
        @"Í   Í" + '\x0';

        public List<StringFrame> StringFramePoses { get; private set; }
        public bool IsLockingAnimation { get; private set; }

        public WalkLeftStringAnimation()
        {
            IsLockingAnimation = false;
            StringFramePoses = new List<StringFrame>()
            {
                new StringFrame(1, WalkingPose1, -1, 0, 40),
                new StringFrame(2, WalkingPose2, -1, 0, 40),
                new StringFrame(3, WalkingPose3, -1, 0, 40),
                new StringFrame(4, WalkingPose4, -1, 0, 40),
                new StringFrame(5, WalkingPose5, -1, 0, 40),
                new StringFrame(6, WalkingPose6, -1, 0, 40),
                new StringFrame(7, WalkingPose7, -1, 0, 40),
                new StringFrame(8, WalkingPose8, -1, 0, 40)
            };
        }
    }
}
