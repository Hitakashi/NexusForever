ALTER TABLE `account`
    ADD COLUMN `authType` TINYINT(1) UNSIGNED NOT NULL DEFAULT '0' AFTER `v`,
    ADD COLUMN `otpSecret` VARCHAR(32) NOT NULL DEFAULT '' AFTER `authType`;
