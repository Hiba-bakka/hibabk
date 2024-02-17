﻿SELECT * FROM users2

CREATE TABLE employes
(
    id INT PRIMARY KEY IDENTITY(1,1),
    employee_id VARCHAR(MAX) NULL,
    full_name VARCHAR(MAX) NULL,
    gender VARCHAR(MAX) NULL,
    contact_number VARCHAR(MAX) NULL,
    position VARCHAR(MAX) NULL,
    image VARCHAR(MAX) NULL,
    salary INT NULL,
    insert_date DATE NULL,
    update_date DATE NULL,
    delete_date DATE NULL,
    [status] VARCHAR(MAX) NULL
)

SELECT * FROM employes

SELECT * FROM employes WHERE delete_date IS NULL