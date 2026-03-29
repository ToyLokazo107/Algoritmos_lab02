using System;

public class GameUtils
{
    public static void Ejecutar<T>(T elemento, Action<T> accion)
    {
        accion(elemento);
    }

    public static bool Validar<T>(T elemento, Func<T, bool> condicion)
    {
        return condicion(elemento);
    }

    public static bool TryFind<T>(T[] array, Func<T, bool> condicion, out T resultado)
    {
        resultado = default;

        for (int i = 0; i < array.Length; i++)
        {
            if (condicion(array[i]))
            {
                resultado = array[i];
                return true;
            }
        }

        return false;
    }
}