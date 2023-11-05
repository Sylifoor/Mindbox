select p.Name + ' - ' + COALESCE(c.Name, '') as 'Product Name - Category Name'
from Products p
left join CategoryProduct pc 
	on p.Id= pc.ProductsId
left join Categories c 
	on pc.CategoriesId = c.Id

-- �� ����� ����, � �� ������ �����, � ����� ���� ���������� ������� ����������, ������� ������� ��� �������.

select p.Name as 'Product Name', c.Name as 'Category Name'
from Products p
left join CategoryProduct pc 
	on p.Id = pc.ProductsId
left join Categories c 
	on c.Id = pc.CategoriesId