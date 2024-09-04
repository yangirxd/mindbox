# Задание 2

Cвязь "многие ко многим", используем дополнительную таблицу:
- Product (Id, Name)  
- Category (Id, Name)  
- ProductCategory (ProductId, CategoryId)  


Для выбора всех пар «Имя продукта – Имя категории» используем запрос:
``` sql
      select 
             p.Name,
             c.Name
      from Products p
      left join ProductCategory pc on p.Id = pc.ProductId
      left join Category c on pc.CategoryId = c.Id
```
