import { NavLink } from 'react-router-dom';
import '../../Style/Footer/Footer.css';


const Footer = () => {
  return (
    <footer className={"extra-footer"}>
      <div className="footer-top">
        <div className="footer-logo">
          <p>My SaaS</p>
        </div>

        <div className="footer-links">
          <NavLink to="/product" className="footer-link">Product</NavLink>
          <NavLink to="/features" className="footer-link">Features</NavLink>
          <NavLink to="/pricing" className="footer-link">Pricing</NavLink>
          <NavLink to="/about" className="footer-link">About</NavLink>
          <NavLink to="/contact" className="footer-link">Contact</NavLink>
        </div>
      </div>

      <div className="footer-bottom">
        <p>&copy; 2026 My SaaS. All rights reserved.</p>
      </div>
    </footer>
  );
};

export default Footer;
