using Android.Content;

namespace MauiApp1
{
    public partial class ManagedConfigurationProvider
    {
        public partial string GetStringValue(string key)
        {
            var manager = (RestrictionsManager)Platform.AppContext.GetSystemService(Context.RestrictionsService);
            var bundle = manager.ApplicationRestrictions;

            if (bundle != null)
            {
                if (bundle.ContainsKey(key))
                    return bundle.GetString(key);
                else
                    return null;
            }

            return null;
        }
    }
}
