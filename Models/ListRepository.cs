using System.Collections.Generic;

namespace ProductSupplier.Models
    {

    // Given. Do not edit.
    public static class ListRepository
        {
        public static readonly List<Supplier> Suppliers = new List<Supplier>
        {
            new Supplier{ SupplierID = 1, Name = "Develop Manufacturing Ltd" },
            new Supplier{ SupplierID = 2, Name = "Venture Thingies"},
            new Supplier{ SupplierID = 3, Name = "Major Manufacturing"},
            new Supplier{ SupplierID = 4, Name = "Mystery Product Co"},
            new Supplier{ SupplierID = 5, Name = "Basement Company"},
            new Supplier{ SupplierID = 6, Name = "Conficio Co"},
            new Supplier{ SupplierID = 7, Name = "Fabrico Manufacturings"},
            new Supplier{ SupplierID = 8, Name = "WeMake IT YouBreak IT" },
            new Supplier{ SupplierID = 9, Name = "Lambent Illumination"}
        };

        public static readonly List<Product> Products = new List<Product>
        {
            new Product{ ProductID = 1, ProductName = "Plumbus", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 1, SupplierID = 6, Price = 42.37},
                new ProdSupplier{ ProductID = 1, SupplierID = 9, Price = 32.34},
                new ProdSupplier{ ProductID = 1, SupplierID = 7, Price = 55.61}
                }
                },

            new Product{ ProductID = 2, ProductName = "Orbital Keys", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 2, SupplierID = 8, Price = 74.17},
                new ProdSupplier{ ProductID = 2, SupplierID = 4, Price = 86.77},
                new ProdSupplier{ ProductID = 2, SupplierID = 6, Price = 63.65}
                }
                },

            new Product{ ProductID = 3, ProductName = "XPress Bottle", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 3, SupplierID = 9, Price = 83.52},
                new ProdSupplier{ ProductID = 3, SupplierID = 6, Price = 91.20},
                new ProdSupplier{ ProductID = 3, SupplierID = 8, Price = 73.89}
                }
                },

            new Product{ ProductID = 4, ProductName = "InstaPress", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 4, SupplierID = 2, Price = 93.99},
                new ProdSupplier{ ProductID = 4, SupplierID = 8, Price = 88.28},
                new ProdSupplier{ ProductID = 4, SupplierID = 5, Price = 71.68}
                }
                },

            new Product{ ProductID = 5, ProductName = "Uno Wear", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 5, SupplierID = 6, Price = 55.00},
                new ProdSupplier{ ProductID = 5, SupplierID = 1, Price = 99.00},
                new ProdSupplier{ ProductID = 5, SupplierID = 2, Price = 91.30}
                }
                },

            new Product{ ProductID = 6, ProductName = "Swish Wallet", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 6, SupplierID = 6, Price = 71.04},
                new ProdSupplier{ ProductID = 6, SupplierID = 9, Price = 83.12},
                new ProdSupplier{ ProductID = 6, SupplierID = 3, Price = 84.17}
                }
                },

            new Product{ ProductID = 7, ProductName = "Onovo Supply", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 7, SupplierID = 7, Price = 51.86},
                new ProdSupplier{ ProductID = 7, SupplierID = 8, Price = 69.07},
                new ProdSupplier{ ProductID = 7, SupplierID = 4, Price = 60.22}
                }
                },

            new Product{ ProductID = 8, ProductName = "Sharpy Knife", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 8, SupplierID = 4, Price = 63.54},
                new ProdSupplier{ ProductID = 8, SupplierID = 8, Price = 55.02},
                new ProdSupplier{ ProductID = 8, SupplierID = 1, Price = 44.85}
                }
                },

            new Product{ ProductID = 9, ProductName = "Towlee", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 9, SupplierID = 7, Price = 44.96},
                new ProdSupplier{ ProductID = 9, SupplierID = 6, Price = 31.81},
                new ProdSupplier{ ProductID = 9, SupplierID = 8, Price = 57.83}
                }
                },

            new Product{ ProductID = 10, ProductName = "Rhino Case", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 10, SupplierID = 7, Price = 24.24},
                new ProdSupplier{ ProductID = 10, SupplierID = 1, Price = 28.45},
                new ProdSupplier{ ProductID = 10, SupplierID = 2, Price = 27.24}
                }
                },

            new Product{ ProductID = 11, ProductName = "Mono", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 11, SupplierID = 3, Price = 69.99},
                new ProdSupplier{ ProductID = 11, SupplierID = 7, Price = 82.51},
                new ProdSupplier{ ProductID = 11, SupplierID = 9, Price = 90.60}
                }
                },

            new Product{ ProductID = 12, ProductName = "Vortex Bottle", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 12, SupplierID = 2, Price = 42.47},
                new ProdSupplier{ ProductID = 12, SupplierID = 1, Price = 46.88},
                new ProdSupplier{ ProductID = 12, SupplierID = 4, Price = 61.24}
                }
                },

            new Product{ ProductID = 13, ProductName = "Handy Mop", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 13, SupplierID = 3, Price = 17.78},
                new ProdSupplier{ ProductID = 13, SupplierID = 8, Price = 89.68},
                new ProdSupplier{ ProductID = 13, SupplierID = 9, Price = 76.21}
                }
                },

            new Product{ ProductID = 14, ProductName = "Terra Shsave", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 14, SupplierID = 8, Price = 90.759},
                new ProdSupplier{ ProductID = 14, SupplierID = 6, Price = 63.43},
                new ProdSupplier{ ProductID = 14, SupplierID = 5, Price = 73.30}
                }
                },

            new Product{ ProductID = 15, ProductName = "Stickem", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 15, SupplierID = 3, Price = 74.82},
                new ProdSupplier{ ProductID = 15, SupplierID = 6, Price = 63.36},
                new ProdSupplier{ ProductID = 15, SupplierID = 7, Price = 50.58}
                }
                },

            new Product{ ProductID = 16, ProductName = "Scruncho", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 16, SupplierID = 2, Price = 58.61},
                new ProdSupplier{ ProductID = 16, SupplierID = 5, Price = 73.29},
                new ProdSupplier{ ProductID = 16, SupplierID = 1, Price = 45.57}
                }
                },

            new Product{ ProductID = 17, ProductName = "Gymr Kit", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 17, SupplierID = 1, Price = 83.09},
                new ProdSupplier{ ProductID = 17, SupplierID = 5, Price = 77.98},
                new ProdSupplier{ ProductID = 17, SupplierID = 4, Price = 69.16}
                }
                },

            new Product{ ProductID = 18, ProductName = "Crash-y-Crash", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 18, SupplierID = 4, Price = 22.03},
                new ProdSupplier{ ProductID = 18, SupplierID = 1, Price = 17.46},
                new ProdSupplier{ ProductID = 18, SupplierID = 8, Price = 18.89}
                }
                },

            new Product{ ProductID = 19, ProductName = "Peek-aboo", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 19, SupplierID = 3, Price = 98.07},
                new ProdSupplier{ ProductID = 19, SupplierID = 1, Price = 98.45},
                new ProdSupplier{ ProductID = 19, SupplierID = 7, Price = 91.68}
                }
                },

            new Product{ ProductID = 20, ProductName = "Empty Space", Prices = new List<ProdSupplier> {
                new ProdSupplier{ ProductID = 20, SupplierID = 5, Price = 27.94},
                new ProdSupplier{ ProductID = 20, SupplierID = 3, Price = 23.40},
                new ProdSupplier{ ProductID = 20, SupplierID = 9, Price = 30.24}
                }
                },
            };
        }
    }