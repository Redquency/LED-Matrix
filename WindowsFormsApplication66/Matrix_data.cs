﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LED_Matrix
{
    public class Matrix_sign
    {
        public char sign { get; set; }
        public Int16[,] msign { get; set; }

    }     

    public class Matrix_data
    {


        List<Matrix_sign> matrix_list = new List<Matrix_sign> //blabla
            {
                new Matrix_sign() { sign='a', msign=new Int16[,] { {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {1,1,1,0,0},
                                                                   {0,0,0,1,0},
                                                                   {0,1,1,1,0},
                                                                   {1,0,0,1,0},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='b', msign=new Int16[,] { {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,0,0},
                                                                   {1,0,0,1,0},
                                                                   {1,0,0,1,0},
                                                                   {1,1,1,0,0}
                                                                                }},

                new Matrix_sign() { sign='A', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='B', msign=new Int16[,] { {1,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='C', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,1},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='D', msign=new Int16[,] { {1,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='E', msign=new Int16[,] { {1,1,1,1,1},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,1,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,1,1}
                                                                                }},
                new Matrix_sign() { sign='F', msign=new Int16[,] { {1,1,1,1,1},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,1,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0}
                                                                                }},
                new Matrix_sign() { sign='G', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,1,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='H', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='I', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='J', msign=new Int16[,] { {0,1,1,1,1},
                                                                   {0,0,0,0,1},
                                                                   {0,0,0,0,1},
                                                                   {0,0,0,0,1},
                                                                   {0,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='K', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,1,0},
                                                                   {1,0,1,0,0},
                                                                   {1,1,0,0,0},
                                                                   {1,0,1,0,0},
                                                                   {1,0,0,1,0},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='L', msign=new Int16[,] { {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,1,1}
                                                                                }},
                new Matrix_sign() { sign='M', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,1,0,1,1},
                                                                   {1,0,1,0,1},
                                                                   {1,0,1,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='N', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,1,0,0,1},
                                                                   {1,0,1,0,1},
                                                                   {1,0,0,1,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='O', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='P', msign=new Int16[,] { {1,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0}
                                                                                }},
                new Matrix_sign() { sign='Q', msign=new Int16[,] { {0,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,1,0,1},
                                                                   {1,0,0,1,1},
                                                                   {0,1,1,1,1}
                                                                                }},
                new Matrix_sign() { sign='R', msign=new Int16[,] { {1,1,1,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,1,1,1,0},
                                                                   {1,0,1,0,0},
                                                                   {1,0,0,1,0},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='S', msign=new Int16[,] { {0,1,1,1,1},
                                                                   {1,0,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {0,1,1,1,0},
                                                                   {0,0,0,0,1},
                                                                   {0,0,0,0,1},
                                                                   {1,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='T', msign=new Int16[,] { {1,1,1,1,1},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0}
                                                                                }},
                new Matrix_sign() { sign='U', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,1,1,0}
                                                                                }},
                new Matrix_sign() { sign='V', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,0,1,0},
                                                                   {0,0,1,0,0}
                                                                                }},
                new Matrix_sign() { sign='W', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {1,0,1,0,1},
                                                                   {1,1,0,1,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='X', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,0,1,0},
                                                                   {0,0,1,0,0},
                                                                   {0,1,0,1,0},
                                                                   {1,0,0,0,1},
                                                                   {1,0,0,0,1}
                                                                                }},
                new Matrix_sign() { sign='Y', msign=new Int16[,] { {1,0,0,0,1},
                                                                   {1,0,0,0,1},
                                                                   {0,1,0,1,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0},
                                                                   {0,0,1,0,0}
                                                                                }},
                new Matrix_sign() { sign='Z', msign=new Int16[,] { {1,1,1,1,1},
                                                                   {0,0,0,0,1},
                                                                   {0,0,0,1,0},
                                                                   {0,0,1,0,0},
                                                                   {0,1,0,0,0},
                                                                   {1,0,0,0,0},
                                                                   {1,1,1,1,1}
                                                                                }},
                new Matrix_sign() { sign=' ', msign=new Int16[,] { {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {0,0,0,0,0},
                                                                   {0,0,0,0,0}
                                                                                }}
                

                                                          // Matrix_sign() mz = matrix_list.Find(sign='a')
                
            };
    
    }
}