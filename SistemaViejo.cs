public static class SistemaViejo
{
    public static decimal CalcularDeposito(decimal total)
    {
        // ERROR ORIGINAL: porcentaje = 0.03m
        // Debía ser 30%, no 3%.
        decimal porcentaje = 0.30m;

        decimal deposito = total * porcentaje;
        return deposito;
    }

    public static decimal APesos(decimal dolares, decimal tasa)
    {
        // ERROR ORIGINAL: dolares / tasa
        // Para convertir de dólares a pesos se debe MULTIPLICAR por la tasa.
        decimal pesos = dolares * tasa;

        return pesos;
    }

    public static decimal TarifaFinDeSemana(decimal tarifa, bool esFinDeSemana)
    {
        if (esFinDeSemana)
        {
            // ERROR ORIGINAL: tarifa * 0.15m
            // Eso calculaba solamente el 15%.
            // Debía multiplicarse por 1.15 para conservar el 100% + 15%.
            tarifa = tarifa * 1.15m;
        }

        return tarifa;
    }

    public static decimal TotalExcursion(int personas, decimal precio)
    {
        decimal subtotal = personas * precio;
        decimal descuento = 0m;

        // ERROR ORIGINAL: personas > 4
        // Con 4 personas también corresponde el descuento.
        if (personas >= 4)
        {
            descuento = subtotal * 0.10m;
        }

        return subtotal - descuento;
    }

    public static decimal TotalMinibar(int cantidad, decimal precio)
    {
        decimal subtotal = cantidad * precio;
        decimal itbis = subtotal * 0.18m;
        decimal total = subtotal + itbis;

        // ERROR ORIGINAL: return subtotal;
        // Se estaba devolviendo el subtotal sin incluir el ITBIS.
        return total;
    }
}