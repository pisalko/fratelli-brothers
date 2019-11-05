import http.server
import socketserver

PORT = 42069
Handler = http.server.SimpleHTTPRequestHandler

with socketserver.TCPServer(( "10.28.109.112", PORT), Handler) as httpd:
    #httpd = socketserver.TCPServer((“”, PORT), Handler) or use this
    print("Serving at port: ", PORT)
    httpd.serve_forever()