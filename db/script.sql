CREATE DATABASE IF NOT EXISTS `orgInformation`;
USE `orgInformation`;

CREATE TABLE overview (
    // Organization ID
    id int(11) NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    org_size VARCHAR(255) NOT NULL,
    org_zip VARCHAR(255) NOT NULL,
    org_address VARCHAR(255) NOT NULL,
    org_city VARCHAR(255) NOT NULL,
    org_phone VARCHAR(255) NOT NULL,
    org_type VARCHAR(255) NOT NULL,
    home_page VARCHAR(255) NOT NULL,
    start_date DATE NOT NULL,
    description VARCHAR(255) NOT NULL,
)
ENGINE = InnoDB;
