import { useState, useEffect } from 'react';
import { NavLink } from 'react-router-dom';
import NavLogo from './Logo';
import '../../Style/nav/Navbar.css';
type props = 
{
  scrl?: boolean
}
const Navbar = ({scrl} : props) => {
  const [scrolled, setScrolled] = useState(false);

  useEffect(() => {
    const handleScroll = () => {
      setScrolled(window.scrollY > 50);
    };

    window.addEventListener('scroll', handleScroll);
    return () => window.removeEventListener('scroll', handleScroll);
  }, []);

  return (
    <header className={`extra-navbar-header ${scrl ? 'scrolled' : scrolled ? 'scrolled' : ''}`}>
      <nav className="extra-navbar">
        <div className="navbar-left">
          <NavLogo />
          <div className="navbar-links">
            <NavLink to="/" className={`navbar-link ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'}`}>Home</NavLink>
            <NavLink to="/product" className={`navbar-link ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'}`}>Product</NavLink>
            <NavLink to="/features" className={`navbar-link ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'}`}>Features</NavLink>
            <NavLink to="/pricing" className={`navbar-link ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'}`}>Pricing</NavLink>
            <NavLink to="/about" className={`navbar-link ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'}`}>About</NavLink>
          </div>
        </div>

        <div className="navbar-right">
          <NavLink to="/login" className={`navbar-login ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-link' : 'initial-link'} login`}>Login</NavLink>
          <NavLink to="/signup" className={`navbar-cta ${scrl ? 'scrolled-link' : scrolled ? 'scrolled-cta' : 'initial-cta'}`}>Get Started</NavLink>
        </div>
      </nav>
    </header>
  );
};

export default Navbar;
