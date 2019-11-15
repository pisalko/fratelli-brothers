
#!/usr/bin/env python
"""
Startup:
    ./dummy-web-server.py -h
    ./dummy-web-server.py -l localhost -p 8000
Send a GET request:
    curl http://localhost:8000
Send a HEAD request:
    curl -I http://localhost:8000
Send a POST request:
    curl -d "foo=bar&bin=baz" http://localhost:8000
"""
import argparse
from http.server import HTTPServer, BaseHTTPRequestHandler

class S(BaseHTTPRequestHandler):

    post_data = "" 
    message = ""

    def _set_headers(self):
        self.send_response(200)
        self.send_header("Content-type", "text/html")
        self.end_headers()
    

    def do_GET(self):
        global post_data #"Hi!"
        global message
        self._set_headers()
        #message = "Hello this is server!"
        print(message) #If VARmessage is the same as last get request, we send "No new orders"String and if message is not the same, we send new order
        b = bytearray()
        b.extend(message) #Either a string that says on order yet
        self.wfile.write(b)

    def do_POST(self):
        global post_data
        global message
        content_length = int(self.headers['Content-Length']) # <--- Gets the size of data
        post_data = self.rfile.read(content_length) # <--- Gets the data itself
        #post_data = post_data[2:-1]
        print (post_data)
        self._set_headers()        
        message = post_data
        

def run(server_class=HTTPServer, handler_class=S, addr="192.168.43.213", port=42069):
    server_address = (addr, port)
    httpd = server_class(server_address, handler_class)

    print(f"Starting http server on {addr}:{port}")
    httpd.serve_forever()

if __name__ == "__main__":

    parser = argparse.ArgumentParser(description="Run a simple HTTP server")
    parser.add_argument(
        "-l",
        "--listen",
        default="145.93.60.244",
        help="Specify the IP address on which the server listens",
    )
    parser.add_argument(
        "-p",
        "--port",
        type=int,
        default=42069,
        help="Specify the port on which the server listens",
    )
    args = parser.parse_args()
    run(addr=args.listen, port=args.port)

