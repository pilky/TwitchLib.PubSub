﻿using System;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// Object representing the arguments for a reward redeem event
    /// </summary>
    public class OnRewardRedeemedArgs : EventArgs
    {
        /// <summary>
        /// Property representing server time stamp
        /// </summary>
        public DateTime TimeStamp;
        /// <summary>
        /// Property representing login name of the user redeemed the reward
        /// </summary>
        public string Login;
        /// <summary>
        /// Property representing displayname of the user redeemed the reward
        /// </summary>
        public string DisplayName;
        /// <summary>
        /// Property representing message of the user
        /// </summary>
        public string Message;
        /// <summary>
        /// Property representing title of the redeemed reward
        /// </summary>
        public string RewardTitle;
        /// <summary>
        /// Property representing prompt of the redeemed reward
        /// </summary>
        public string RewardPrompt;
        /// <summary>
        /// Property representing cost of the redeemed reward
        /// </summary>
        public int RewardCost;
    }
}
