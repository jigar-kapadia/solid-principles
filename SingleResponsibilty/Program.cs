using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> list, ISpecification<T> specification);
    }

    public interface ISpecification<T>
    {
        bool IsFulfilled(Product product);
    }

    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> list, ISpecification<Product> specification)
        {
           return list.Where(product => specification.IsFulfilled(product));
        }
    }

    public class BrandSpecification : ISpecification<Product>
    {
        private string _brand;
        public BrandSpecification(string brand)
        {
            this._brand = brand;
        }
        public bool IsFulfilled(Product product)
        {
            return product.Brand.ToLower() == this._brand.ToLower();
        }
    }

    public class TypeSpecification : ISpecification<Product>
    {
        private readonly string _type;

        public TypeSpecification(string type)
        {
            _type = type;
        }
        public bool IsFulfilled(Product product)
        {
            return product.Type.ToLower() == _type.ToLower();
        }
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private readonly string _color;
        public ColorSpecification(string color)
        {
            _color = color;
        }
        public bool IsFulfilled(Product product)
        {
            return product.Color.ToLower() == _color.ToLower();
        }
    }

    public class AndSpecification : ISpecification<Product>
    {
        private ISpecification<Product> _spec1, _spec2;
        private ISpecification<Product>[] _specArray;
        public AndSpecification(params ISpecification<Product>[] specs)
        {
            _specArray = specs;

            //_spec1 = spec1;
            //_spec2 = spec2;
        }

        public bool IsFulfilled(Product product)
        {
            if (_specArray.Length == 2)
                return _specArray[0].IsFulfilled(product) && _specArray[1].IsFulfilled(product);
            else if (_specArray.Length == 3)
                return _specArray[0].IsFulfilled(product) && _specArray[1].IsFulfilled(product) &&
                    _specArray[2].IsFulfilled(product);
            else
                return false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product();
            var products = product.GetProducts();
            var productFilter = new ProductFilter();

            //All Apple
            Console.WriteLine("All Apple Mobiles Available");
            Console.WriteLine();
            foreach (var item in productFilter.Filter(products, new BrandSpecification("Apple")))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            //All Tablets
            Console.WriteLine("All Tablets Available");
            Console.WriteLine();
            foreach (var item in productFilter.Filter(products, new TypeSpecification("Tablet")))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            //All silver color
            Console.WriteLine("All Silver Color Products Available");
            Console.WriteLine();
            foreach (var item in productFilter.Filter(products, new ColorSpecification("Silver")))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            //All black mobile
            Console.WriteLine("All Black Color Mobiles Available");
            Console.WriteLine();
            foreach (var item in productFilter.Filter(products, 
                new AndSpecification(new TypeSpecification("mobile"), new ColorSpecification("black"))))
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
