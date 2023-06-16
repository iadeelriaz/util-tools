using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class GlobalPrefs : MonoBehaviour
    {
        private const string Currency = "Currency";
        private const string Player = "SelectedPlayer";
        private const string Controls = "SelectedControls";
        private const string Mode = "SelectedMode";
        private const string Mission = "SelectedMission";
        
        private const string Level = "SelectedLevel";

        private const string RewardDay = "DailyRewardDay";
        private const string Tutorial = "TutorialComplete";

        private const string Policy = "PrivacyPolicy";

        public static int PrivacyPolicy
        {
            get => PlayerPrefs.GetInt(Policy, 0);
            set => PlayerPrefs.SetInt(Policy, value);
        }

        public static int CurrentAmount
        {
            get => PlayerPrefs.GetInt(Currency, 0);
            set => PlayerPrefs.SetInt(Currency, value);
        }

        public static int SelectedPlayer
        {
            get => PlayerPrefs.GetInt(Player, 0); 
            set => PlayerPrefs.SetInt(Player, value);
        }
    
        public static int SelectedLevel
        {
            get => PlayerPrefs.GetInt(Level, 0); 
            set => PlayerPrefs.SetInt(Level, value);
        }
    
        public static int SelectedControls
        {
            get => PlayerPrefs.GetInt(Controls, 0); 
            set => PlayerPrefs.SetInt(Controls, value);
        }
    
        public static int SelectedMode
        {
            get => PlayerPrefs.GetInt(Mode, 0); 
            set => PlayerPrefs.SetInt(Mode, value);
        }

        public static int SelectedMission
        {
            get => PlayerPrefs.GetInt(Mission, 0);
            set => PlayerPrefs.SetInt(Mission, value);
        }

        public static int DailyRewardDay
        {
            get => PlayerPrefs.GetInt(RewardDay, 1);
            set => PlayerPrefs.SetInt(RewardDay, value);
        }  
    
        public static int TutorialComplete
        {
            get => PlayerPrefs.GetInt(Tutorial, 0);
            set => PlayerPrefs.SetInt(Tutorial, value);
        }
    }
}
