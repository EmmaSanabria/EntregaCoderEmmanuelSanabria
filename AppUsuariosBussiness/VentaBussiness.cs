using System.Collections.Generic;
using AppUsuariosData;
using AppUsuariosEntities;

namespace AppUsuariosBusiness
{
    public class VentaBusiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.GetVentas();
        }

        public static void CreateVenta(Venta venta)
        {
            VentaData.CreateVenta(venta);
        }

        public static void UpdateVenta(Venta venta)
        {
            VentaData.UpdateVenta(venta);
        }

        public static void DeleteVenta(int id)
        {
            VentaData.DeleteVenta(id);
        }
    }
}
