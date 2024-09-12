# Задание 1
В [Mindbox.Library](Mindbox.Library/) находится библиотека которая была описана в задаче. В [Mindbox.Example](Mindbox.Example/) находится консольное приложение с запуском функций библиотеки. В [Mindbox.Library.Tests](Mindbox.Library.Tests/) находятся unit тесты
# Задание 2
### Запрос
```sql
SELECT 
    p.ProductName AS ProductName,
    c.CategoryName AS CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN 
    Categories c ON pc.CategoryId = c.CategoryId
ORDER BY 
    p.ProductName, c.CategoryName;
```
### Описание
Так как связь многие ко многим, сделал связующую таблицу между продуктами и категориями `ProductCategories`
