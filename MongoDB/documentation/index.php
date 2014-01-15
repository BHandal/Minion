# DO NOT REMOVE THIS LINE AND THE LINES BELOW REDIRECTID:H6NBBi
RewriteEngine on

#Domain redirect
RewriteCond %{HTTP_HOST} ^bygons\.com$
RewriteRule ^(.*) http://www.bygons.com/$1 [R=301]

#404 error
ErrorDocument 403 /error.php
ErrorDocument 404 /error.php
ErrorDocument 500 /error.php

RewriteRule ^mail/$ http://webmail.000webhost.com/roundcube/ [R=301,L]
# DO NOT REMOVE THIS LINE AND THE LINES ABOVE H6NBBi:REDIRECTID







