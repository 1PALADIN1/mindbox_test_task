SELECT p.name, t.name FROM products p
LEFT JOIN (
    SELECT pc.product_id, c.name FROM products_categories pc
    INNER JOIN categories c ON pc.category_id = c.id
) t ON t.product_id = p.id