# CalcArea
Solution for calculation area circle, rectangle and triangle
Вопрос 9
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT * product.name as product FROM product_sheet WHERE category.name IS NOT NULL IN
    (SELECT * product.name as product FROM product_sheet WHERE category.name IS NULL);
