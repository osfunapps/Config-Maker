namespace Config_Maker
{
    internal class TextTemplateHandler
    {
        //ac remotes start
        public static string SWING_TXT = "swing \n";
        public static string FAN_SPEED_TXT = "fan_speed \n";
        public static string TEMP_UP_TXT = "temp_up \n";
        public static string TEMP_DOWN_TXT = "temp_down \n";
        public static string MODE_TXT = "mode \n";
        public static string POWER_1_TXT = "power_on \n";
        public static string POWER_2_TXT = "power_off \n";
        
        /*public static string SCREEN_ELEMENT_TAG = "screen_element_";
        public static string SWING_TXT = SCREEN_ELEMENT_TAG + "swing \n";
        public static string FAN_SPEED_TXT = SCREEN_ELEMENT_TAG + "fan_speed \n";
        public static string TEMP_UP_TXT = SCREEN_ELEMENT_TAG + "temp_up \n";
        public static string TEMP_DOWN_TXT = SCREEN_ELEMENT_TAG + "temp_down \n";
        public static string MODE_TXT = SCREEN_ELEMENT_TAG + "mode \n";
        public static string POWER_1_TXT = SCREEN_ELEMENT_TAG + "power_on \n";
        public static string POWER_2_TXT = "power_off \n";
        */

        public static string AI_TXT = "AI";
        public static string WIND_TXT = "wind \n";

        //modes
        public static string MODES = "modes";
        public static string COLD = "cold";
        public static string HOT = "hot";
        public static string wind = "wind";


        public static string MAX_FAN_POWER = "max_fan_power";
        public static string DEGREE_TYPE = "degree_type";

        //no display params
        public static string POWER_NO_DISPLAY_1_TXT = "power_1 \n";
        public static string POWER_NO_DISPLAY_2_TXT = "power_2 \n";
        //ac remotes end

        //normal remotes
        public static string NUMBERS_TXT = "1 2 3 4 5 6 7 8 9 __ 0 __ ";
        public static string VCR_TXT = "rewind pause forward record play stop ";
        public static string NAVIGATION_TXT = "up down left right select ";
        public static string CHANNEL_TXT = "chan_up chan_down ";
        public static string COLORS_TXT = "red green yellow blue ";
        public static string VOLUME_TXT = "device_vol+ device_vol- device_mute ";
    }
}