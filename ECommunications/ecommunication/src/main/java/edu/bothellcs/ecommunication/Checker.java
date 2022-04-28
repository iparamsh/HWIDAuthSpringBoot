package edu.bothellcs.ecommunication;

import java.util.concurrent.atomic.AtomicLong;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class Checker {
	@GetMapping("/check")
	public String check(@RequestParam(value = "name", defaultValue = "null") String name) {
		if (name.equals("null")) 
		{
			return String.format("No access!!!");
		}
		else 
		{
			if (!checkIfServerUser(name)) {
				return String.format("No access!!!");
			}
		}
		return String.format("ACCEPTED %s!", name);
	}
	
	private boolean checkIfServerUser(String name) {
		if (name.equals("090B-67E1")) 
			return true;
		return false;
	}
}


