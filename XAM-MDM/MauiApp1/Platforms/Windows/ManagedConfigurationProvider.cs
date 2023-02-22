using Windows.Storage;

namespace MauiApp1
{
    public partial class ManagedConfigurationProvider
    {
        public const string MangedConfigurationKey = "Managed.App.Settings";

        public partial string GetStringValue(string key)
        {
            ApplicationDataContainer container = null;
            if (ApplicationData.Current.LocalSettings.Containers.TryGetValue(MangedConfigurationKey, out container))
            {
                object value = null;
                if (container.Values.TryGetValue(key, out value) && value != null)
                    return value.ToString();
            }

            return null;
        }
    }
}
