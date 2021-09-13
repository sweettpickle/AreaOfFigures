SELECT * FROM Products 
LEFT JOIN Categories 
ON Products.Id = Categories.Id

//если есть таблица-связка
SELECT * FROM Products 
LEFT JOIN ProductsToCategories 
ON Products.Id = ProductsToCategories.ProductId 
LEFT JOIN Categories 
ON Categories.Id = ProductsToCategories.CategoryId
