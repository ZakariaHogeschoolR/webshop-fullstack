import { Link } from 'react-router-dom';
import logo from '../../../assets/kyriacos-georgiou-CMmgfHQiYsc-unsplash.jpg';
import '../../Style/nav/NavLogo.css';

const NavLogo = () => {
  return (
    <div className="nav-logo">
      <Link to="/" aria-label="Go to homepage">
        <img
          src={logo}
          alt="Webshop logo"
          className="nav-logo-img"
          loading="eager"
        />
      </Link>
    </div>
  );
};

export default NavLogo;
