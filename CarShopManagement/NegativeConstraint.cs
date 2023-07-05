namespace CarShopManagement
{
    public class NegativeConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (int.TryParse(values["id"].ToString(), out int id))
            {
                if (id > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
