namespace ReflectionDmeo
{
    internal class ExploreObjectService
    {
        public static void ShowMeYouProperties(object obj)
        {
            Console.WriteLine($"*** {obj }***");
            var type = obj.GetType();
            var propertyInfos = type.GetProperties();
            foreach (var prop in propertyInfos)
            {
                try
                {
                    Console.WriteLine($"{prop.Name} = {prop.GetValue(obj)}");
                }
                catch
                {
                }
            }
        }
    }
}
