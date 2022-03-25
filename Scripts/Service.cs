using System.Runtime.CompilerServices;

namespace AffenCode.ServiceLocator
{
    public static class Service<T> where T : class, new()
    {
        private static T _instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Set(T instance)
        {
            _instance = instance;
            return _instance;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get()
        {
            return _instance;
        }
    }
}