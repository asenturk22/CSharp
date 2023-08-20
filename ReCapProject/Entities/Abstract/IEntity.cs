using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEntity
    {
    }
}




/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 *          _________________   _________________   _____________________
 *          |               |   |               |   |                   |
 *          |   CAR         |   |   COLOR       |   |    BRAND          | 
 *          |_______________|   |_______________|   |___________________|
 *                           \           |            / 
 *                            \          |           /
 *                             \         |          /
 *                              \        |         /
 *                        _______\_______|________/__
 *                        |                          |
 *                        |         IEntity          |
 *                        |__________________________|
 * 
 */