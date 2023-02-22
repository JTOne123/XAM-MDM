using Foundation;

namespace MauiApp1
{
    public partial class ManagedConfigurationProvider
    {
        public const string MangedConfigurationKey = "com.apple.configuration.managed";

        public partial string GetStringValue(string key)
        {
            var dic = NSUserDefaults.StandardUserDefaults.DictionaryForKey(MangedConfigurationKey);
            if (dic != null)
            {
                NSObject value = null;
                if (dic.TryGetValue(new NSString(key), out value) && value != null)
                    return value.ToString();
            }

            return null;
        }
    }
}
